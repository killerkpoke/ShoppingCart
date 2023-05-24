<script setup lang="ts">
    const counter = useCounter()
    const price = usePrice()
</script>
<template>
    <div>
        <div class="navbar bg-base-100">
            <div class="flex-1">
                <div class="dropdown ">
                    <label tabindex="0" class="btn btn-ghost btn-square">
                        <div class="indicator">
                            <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" class="inline-block w-5 h-5 stroke-current"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 6h16M4 12h16M4 18h16"></path></svg>
                        </div>
                    </label>
                    <div tabindex="0" class="mt-3 card card-compact dropdown-content w-56 bg-base-300 shadow">
                        <div class="card-body">
                            <ul class="menu bg-base-300 w-48 p-2 rounded-box">
                                <li class="menu-title mb-2">
                                    <span>Methods</span>
                                </li>
                                <li>
                                    <button class="btn btn-secondary btn-block text-white my-2">
                                        <!-- <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5"  viewBox="0 0 448 512"><path d="M256 80c0-17.7-14.3-32-32-32s-32 14.3-32 32V224H48c-17.7 0-32 14.3-32 32s14.3 32 32 32H192V432c0 17.7 14.3 32 32 32s32-14.3 32-32V288H400c17.7 0 32-14.3 32-32s-14.3-32-32-32H256V80z"/></svg> -->
                                        <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 512 512"><path d="M362.7 19.3L314.3 67.7 444.3 197.7l48.4-48.4c25-25 25-65.5 0-90.5L453.3 19.3c-25-25-65.5-25-90.5 0zm-71 71L58.6 323.5c-10.4 10.4-18 23.3-22.2 37.4L1 481.2C-1.5 489.7 .8 498.8 7 505s15.3 8.5 23.7 6.1l120.3-35.4c14.1-4.2 27-11.8 37.4-22.2L421.7 220.3 291.7 90.3z"/></svg>
                                        <NuxtLink to="/manageview">
                                            Manage Items
                                        </NuxtLink>
                                    </button>
                                    <!-- <button class="btn btn-warning btn-block text-white my-2">
                                        <NuxtLink to="/updateOrDeleteItem">
                                            Update Item
                                        </NuxtLink>
                                    </button>
                                    <button class="btn btn-error btn-block text-white my-2">
                                        <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 448 512"><path d="M135.2 17.7L128 32H32C14.3 32 0 46.3 0 64S14.3 96 32 96H416c17.7 0 32-14.3 32-32s-14.3-32-32-32H320l-7.2-14.3C307.4 6.8 296.3 0 284.2 0H163.8c-12.1 0-23.2 6.8-28.6 17.7zM416 128H32L53.2 467c1.6 25.3 22.6 45 47.9 45H346.9c25.3 0 46.3-19.7 47.9-45L416 128z"/></svg>
                                        <NuxtLink to="/deleteItem">
                                            Delete Item
                                        </NuxtLink>
                                    </button> -->
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class="flex-auto justify-center">
                <h1 class="text-center font-bold text-5xl my-6 text-white cursor-pointer">
                    <NuxtLink to="/">
                        Emotional Fruit Shop
                    </NuxtLink>
                </h1>
            </div>
            <div class="flex-1 justify-end">
                <div class="dropdown dropdown-end">
                    <label tabindex="0" class="btn btn-ghost btn-square">
                        <div class="indicator">
                            <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" fill="none" viewBox="0 0 24 24" stroke="currentColor"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M3 3h2l.4 2M7 13h10l4-8H5.4M7 13L5.4 5M7 13l-2.293 2.293c-.63.63-.184 1.707.707 1.707H17m0 0a2 2 0 100 4 2 2 0 000-4zm-8 2a2 2 0 11-4 0 2 2 0 014 0z" /></svg>
                            <span class="badge badge-sm indicator-item">{{ counter }}</span>
                        </div>
                    </label>
                    <div tabindex="0" class="mt-3 card card-compact dropdown-content w-52 bg-base-100 shadow">
                        <div class="card-body">
                            <span class="font-bold text-lg">{{ counter }} Items</span>
                            <span class="text-info">Subtotal: ${{ price }}</span>
                            <div class="card-actions">
                                <button class="btn btn-primary btn-block">
                                    <NuxtLink to="/cartview">
                                        View cart
                                    </NuxtLink>
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>