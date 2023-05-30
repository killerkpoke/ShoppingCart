<script setup lang="ts">
const data = {
    
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
                        <tr class="[&>*]:bg-[#1c1f25]">
                            <th>
                                <label>
                                    <input type="checkbox" class="checkbox" />
                                </label>
                            </th>
                            <td>
                                <div class="mask mask-squircle w-12 h-12">1</div>
                            </td>
                            <td>
                                <div class="flex items-center space-x-3">
                                    <div>
                                        <div class="font-bold">Banana</div>
                                    </div>
                                </div>
                            </td>
                                
                            <td>666</td>
                            <td>69</td>
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