<script setup lang="ts">
import { useToast, POSITION  } from "vue-toastification";

const localItem = useState('localData');
const fruitList = useState('localFruit');

onMounted(() => {
    const data = localStorage.getItem('newItem') || "{}";
    localItem.value = data;
    fruitList.value = JSON.parse(data);
})
function updateItem(_fruit: Fruit) {
    localStorage.setItem('updateItem', JSON.stringify(_fruit));
}
function deleteItem(_fruit: Fruit) {
    const index = fruitList.value.indexOf(_fruit)
    if (index > -1) {
        fruitList.value.splice(index, 1);
        
        localStorage.setItem('newItem', JSON.stringify(fruitList.value));
        
        const toast = useToast();
        toast.success("Deleted an item successfully!", {
            timeout: 3000,
            position: POSITION.BOTTOM_RIGHT,
        });
    }
}
</script>
<template>
    <div>
        <Header></Header>
        <div class="m-6">
            <div class="flex items-center">
                <h1 class="text-4xl m-4 font-semibold">Management View</h1>
                <button class="btn btn-success">
                    <NuxtLink to="/addItemview">
                        Add new item
                    </NuxtLink>
                </button>
            </div>
            <div class="overflow-x-auto w-full">
                <table class="table w-full">
                    <thead>
                        <tr class="[&>*]:text-center">
                            <th>ID</th>
                            <th>Name</th>
                            <th>Price</th>
                            <th>Quantity</th>
                            <th>Functions</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr 
                       v-for="(item, index) in fruitList" :key="index"
                        class="[&>*]:bg-[#1c1f25] [&>*]:text-center">
                            <td>
                                <div>{{ item.id }}</div>
                            </td>
                            <td>
                                <div class="font-bold capitalize">{{ item.name }}</div>
                            </td> 
                            <td>${{ item.price }}/each</td>
                            <td>{{ item.quantity }}</td>
                            <th>
                                <div class="inline-grid">
                                <button class="btn btn-warning btn-xl text-white my-2"
                                @click="updateItem(item)">
                                    <NuxtLink to="/updateItemview">
                                        Update Item
                                    </NuxtLink>
                                </button>
                                <button class="btn btn-error btn-xl text-white my-2"
                                @click="deleteItem(item)">
                                    Delete Item
                                </button></div>
                            </th>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</template>