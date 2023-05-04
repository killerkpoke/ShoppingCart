<template>
    <div class="m-4 rounded-xl text-black 2xl:w-full max-w-2xl w-auto">
        <div class="border-t-4 border-gray-700 border-x-4 rounded-t-xl bg-[#e075b5] p-4 md:flex grid">
            <div class="mx-4">
                <p class="text-center text-xl font-bold">{{dd?.name}}</p>
                <p class="text-center mt-10">{{ dd?.desc }}</p>
            </div>
            <!-- <div class="place-self-center mt-4"> -->
                <img class="border-2 border-black rounded-xl w-32 h-32 place-self-center mt-4" src="https://icon-library.com/images/banana-icon/banana-icon-5.jpg"/>
            <!-- </div> -->
        </div>
        <div class="border-b-4 border-gray-700 border-x-4 rounded-b-xl bg-[#f3a5d3] p-4 grid">
        <div> 
            <div v-for="tag in dd?.tags" :key="tag.id" class="tooltip tooltip-bottom mr-1" :data-tip="tag?.desc">
                <p class="badge font-bold p-3" :class="`badge-`+tag?.context">{{ tag?.name }}</p>
            </div>
        </div>
            <button class="btn btn-primary mt-4 place-self-center capitalize">
                <label>Buy</label>
                <label class="px-2">{{ dd?.id }}</label>    
            </button>
        </div>
    </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue'
export default defineComponent({
    name: 'Cards',
    props: {
        dummy: Object
    },
    setup(props) {
        return { dd: props.dummy } 
    }
})
</script>
