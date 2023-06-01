<script setup lang="ts">

const localItem:string = localStorage.getItem('newItem') || "{}";
const fruitList:Fruit = JSON.parse(localItem);

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
                        <tr>
                            <th>
                                <label>
                                    <input type="checkbox" class="checkbox" />
                                </label>
                            </th>
                            <th>ID</th>
                            <th>Name</th>
                            <th>Price</th>
                            <th>Quantity</th>
                            <th>Functions</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr 
                       v-for="item of fruitList" :key="item.name"
                        class="[&>*]:bg-[#1c1f25]">
                            <th>
                                <label>
                                    <input type="checkbox" class="checkbox" />
                                </label>
                            </th>
                            <td>
                                <div>{{ item.id }}</div>
                            </td>
                            <td>
                                <div class="flex items-center space-x-3">
                                    <div>
                                        <div class="font-bold">{{ item.name }}</div>
                                    </div>
                                </div>
                            </td>
                                
                            <td>{{ item.price }}</td>
                            <td>{{ item.quantity }}</td>
                            <th>
                                <div class="inline-grid">
                                <button class="btn btn-warning btn-xl text-white my-2">
                                    <NuxtLink to="/updateItemview">
                                        Update Item
                                    </NuxtLink>
                                </button>
                                <button class="btn btn-error btn-xl text-white my-2">
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