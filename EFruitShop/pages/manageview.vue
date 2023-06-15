<script setup lang="ts">
import { useToast, POSITION  } from "vue-toastification";

const localItem:string = localStorage.getItem('newItem') || "{}";
const fruitList:Array<Fruit> = JSON.parse(localItem);
const fruit = useFruit();

function deleteItem(_fruit: Fruit) {
    const index = fruitList.indexOf(_fruit)
    if (index > -1) {
        fruitList.splice(index, 1);

        localStorage.setItem('newItem', JSON.stringify(fruitList));
        
        fruit.value = fruitList;
        
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
            <div v-if="isDeleted" class="flex place-content-center">
                <div class="alert alert-warning shadow-lg my-6 m-full max-w-max">
                    <div>
                        <svg xmlns="http://www.w3.org/2000/svg" class="stroke-current flex-shrink-0 h-6 w-6" fill="none" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M9 12l2 2 4-4m6 2a9 9 0 11-18 0 9 9 0 0118 0z" /></svg>
                        <span>You deleted an item successfully!</span>
                    </div>
                </div>
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
                                <button class="btn btn-warning btn-xl text-white my-2">
                                    <NuxtLink to="/updateItemview">
                                        Update Item
                                    </NuxtLink>
                                </button>
                                <button class="btn btn-error btn-xl text-white my-2"
                                @click="deleteItem(item)">
                                    <!-- <NuxtLink to="/deleteItem"> -->
                                        Delete Item
                                    <!-- </NuxtLink> -->
                                </button></div>
                            </th>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</template>