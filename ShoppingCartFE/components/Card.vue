<template>
    <div class="m-4 rounded-xl text-black md:w-1/2 w-full">
        <div class="border-t-4 border-gray-700 border-x-4 rounded-t-xl bg-[#e075b5] p-4 flex">
            <div class="w-full mr-2">
                <p class="text-center text-xl font-bold">Big Cute Banana</p>
                <p class="text-center mt-10">About the item a very very very very very very very very long</p>
            </div>
            <img class="border-2 border-black rounded-xl w-full" src="https://icon-library.com/images/banana-icon/banana-icon-5.jpg"/>
        </div>
        <div class="border-b-4 border-gray-700 border-x-4 rounded-b-xl bg-[#f3a5d3] p-4 grid">
            <p class="badge badge-info font-bold p-3">Healty</p>
            <button class="btn btn-primary mt-4 w-1/2 place-self-center capitalize">
                <label>Buy</label>
                <label class="px-2">1x</label>    
            </button>
        </div>
    </div>
</template>

<script>
export default {
  name: 'MyCard',
}
</script>