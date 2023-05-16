<script setup lang="ts">
    let price = usePrice()
    const selectedItem = useSelectedItems()   
</script>

<template>
    <div>
        <Header></Header>
        <div class="w-auto flex place-content-center py-4">
            <table v-if="selectedItem.length != 0" class="table table-auto text-white">
                <tr class="text-center">
                    <th>Name</th>
                    <th>Price</th>
                    <th>Quantity</th>
                </tr>
                <tr v-for="item in selectedItem" :key="item.id">
                    <td>{{ item.name }}</td>
                    <td>{{ item.price }}</td>
                    <td class="flex font-bold text-center">
                        <button class="btn btn-primary text-xl">-</button>
                        <p class="m-3">{{ item.quantity }}</p>
                        <button class="btn btn-primary text-xl">+</button>
                    </td>
                </tr>
            </table>
            <p v-else class="text-red-400 font-bold- text-2xl">There is no item in the cart</p>
        </div>
        <div class="flex place-content-center">
            <div class="divider w-3/4 font-extrabold text-2xl ">Final Price: ${{price}}</div>
        </div>
        <div class="flex place-content-center mb-6 mt-4">
            <div class="m-2">
                <button class="btn btn-warning">
                    <NuxtLink to="/" class="flex">
                        <svg class="w-6 h-6 mr-4" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512"><path d="M9.4 233.4c-12.5 12.5-12.5 32.8 0 45.3l160 160c12.5 12.5 32.8 12.5 45.3 0s12.5-32.8 0-45.3L109.2 288 416 288c17.7 0 32-14.3 32-32s-14.3-32-32-32l-306.7 0L214.6 118.6c12.5-12.5 12.5-32.8 0-45.3s-32.8-12.5-45.3 0l-160 160z"/></svg>
                        <p class="place-self-center">Go back</p>
                    </NuxtLink>
                </button>
            </div>
            <div class="m-2">
                <button class="btn btn-success w-44">
                    <NuxtLink to="/" class="flex">
                        <svg class="w-6 h-6 mr-4" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 576 512"><path d="M0 24C0 10.7 10.7 0 24 0H69.5c22 0 41.5 12.8 50.6 32h411c26.3 0 45.5 25 38.6 50.4l-41 152.3c-8.5 31.4-37 53.3-69.5 53.3H170.7l5.4 28.5c2.2 11.3 12.1 19.5 23.6 19.5H488c13.3 0 24 10.7 24 24s-10.7 24-24 24H199.7c-34.6 0-64.3-24.6-70.7-58.5L77.4 54.5c-.7-3.8-4-6.5-7.9-6.5H24C10.7 48 0 37.3 0 24zM128 464a48 48 0 1 1 96 0 48 48 0 1 1 -96 0zm336-48a48 48 0 1 1 0 96 48 48 0 1 1 0-96z"/></svg>
                        <p class="place-self-center">Checkout</p>
                    </NuxtLink>
                </button>
            </div>
        </div>
        
        <Footer></Footer>
    </div>
</template>