<script setup lang="ts">

const localItem:string = localStorage.getItem('newItem') || "{}";
const fruitList:Array<Fruit> = JSON.parse(localItem);

function deleteItem(id: number) {
    for (let i = 0; i < fruitList.length; i++) {
        if (fruitList[i].id == id) {
            fruitList.splice(i);
            // update the fruit state
            localStorage.setItem('newItem', JSON.stringify(fruitList))
            break;
        }
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
                                <button class="btn btn-warning btn-xl text-white my-2">
                                    <NuxtLink to="/updateItemview">
                                        Update Item
                                    </NuxtLink>
                                </button>
                                <button class="btn btn-error btn-xl text-white my-2"
                                @click="deleteItem(item.id)">
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