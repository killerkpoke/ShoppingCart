<script setup lang="ts">
    const counter = useCounter()
    const price = usePrice()
</script>
<template>
    <div>
        <div class="navbar bg-base-100">
            <div class="flex-1">
                <button class="btn btn-square btn-ghost">
                    <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" class="inline-block w-5 h-5 stroke-current"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 6h16M4 12h16M4 18h16"></path></svg>
                </button>
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