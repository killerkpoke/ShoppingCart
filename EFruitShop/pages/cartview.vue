<script setup lang="ts">
    const counter = useCounter()
    const price = usePrice()
</script>

<template>
    <div>
        <Header></Header>
        <div class="w-auto flex place-content-center py-4">
            <table class="table table-auto text-white">
                <tr class="text-center">
                    <th>Name</th>
                    <th>Price</th>
                    <th>Quantity</th>
                </tr>
                <tr>
                    <td>Alfreds Futterkiste</td>
                    <td>$999</td>
                    <td class="flex font-bold text-center">
                        <button class="btn btn-primary text-xl">-</button>
                        <p class="m-3">4</p>
                        <button class="btn btn-primary text-xl">+</button>
                    </td>
                </tr>
                <tr>
                    <td>Centro comercial Moctezuma</td>
                    <td>$433</td>
                    <td class="flex font-bold text-center">
                        <button class="btn btn-primary text-xl">-</button>
                        <p class="m-3">3</p>
                        <button class="btn btn-primary text-xl">+</button>
                    </td>
                </tr>
            </table>
        </div>
        <div class="flex place-content-center">
            <div class="divider w-3/4">OR</div>
        </div>
        <div class="flex place-content-center mb-6 mt-4">
            <div class="m-2">
                <button class="btn btn-warning w-44">
                    <svg class="w-6 h-6 mr-4" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512"><path d="M9.4 233.4c-12.5 12.5-12.5 32.8 0 45.3l160 160c12.5 12.5 32.8 12.5 45.3 0s12.5-32.8 0-45.3L109.2 288 416 288c17.7 0 32-14.3 32-32s-14.3-32-32-32l-306.7 0L214.6 118.6c12.5-12.5 12.5-32.8 0-45.3s-32.8-12.5-45.3 0l-160 160z"/></svg>
                    Go back
                </button>
            </div>
            <div class="m-2">
                <button class="btn btn-success w-44">
                    <svg class="w-6 h-6 mr-4" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 576 512"><path d="M0 24C0 10.7 10.7 0 24 0H69.5c22 0 41.5 12.8 50.6 32h411c26.3 0 45.5 25 38.6 50.4l-41 152.3c-8.5 31.4-37 53.3-69.5 53.3H170.7l5.4 28.5c2.2 11.3 12.1 19.5 23.6 19.5H488c13.3 0 24 10.7 24 24s-10.7 24-24 24H199.7c-34.6 0-64.3-24.6-70.7-58.5L77.4 54.5c-.7-3.8-4-6.5-7.9-6.5H24C10.7 48 0 37.3 0 24zM128 464a48 48 0 1 1 96 0 48 48 0 1 1 -96 0zm336-48a48 48 0 1 1 0 96 48 48 0 1 1 0-96z"/></svg>
                    Checkout
                </button>
            </div>
        </div>
        
        <Footer></Footer>
    </div>
</template>