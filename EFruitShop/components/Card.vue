<script setup lang="ts">
    let prop = defineProps(['dummy'])
    let counter = useCounter()
    let price = usePrice()
    let localCounter = ref(0)
    let selectedItem = useSelectedItems()
    let tempImg = new Image();
    tempImg.src = prop.dummy.image;
    prop.dummy.tempImage = tempImg.src;

    function add() {
        counter.value++
        localCounter.value++
        price.value += +prop.dummy.price

        const item = {
            "id": prop.dummy.id,
            "name":prop.dummy.name,
            "price": prop.dummy.price * localCounter.value,
            "priceEach": prop.dummy.price,
            "quantity":localCounter.value,
        }
        for (let i of selectedItem.value) {
            if (item.id === i.id ) {
                const index = selectedItem.value.indexOf(i)
                if (index > -1) selectedItem.value.splice(index, 1)
            }
        }
        selectedItem.value.push(item) 
    }
</script>

<template>
    <div class="m-4 rounded-xl text-black 2xl:w-full max-w-2xl w-auto">
        <div class="border-t-4 border-gray-700 border-x-4 rounded-t-xl bg-[#e075b5] p-4 md:flex grid">
            <div class="mx-4">
                <p class="text-center text-xl font-bold">{{ prop.dummy.name }}</p>
                <p class="text-center mt-10">{{ prop.dummy.description }}</p>
            </div>
            <img class="border-2 border-black rounded-xl w-32 h-32 place-self-center mt-4" 
            :src="prop.dummy.tempImage"
            />
        </div>
        <div class="border-b-4 border-gray-700 border-x-4 rounded-b-xl bg-[#f3a5d3] p-4 grid">
        <div> 
            <div v-for="tag in prop.dummy.tags" :key="tag.id" class="tooltip tooltip-bottom mr-1" :data-tip="tag?.description">
                <p class="font-bold p-3" :class="'badge badge-'+tag?.context">{{ tag?.name }}</p>
            </div>
            <div class="mt-2 font-bold">
                <label>Price:</label>
                <label>${{ prop.dummy.price }}</label>
            </div>
        </div>
        <button class="btn btn-primary mt-4 place-self-center capitalize" @click=add>
            <label class="cursor-pointer">Buy</label>
            <label class="px-2 cursor-pointer">{{ localCounter }}x</label>
        </button>
        </div>
    </div>
</template>

