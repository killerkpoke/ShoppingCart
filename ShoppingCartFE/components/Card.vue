<template>
    
    <div class="m-4 rounded-xl text-black 2xl:w-full max-w-2xl w-auto">
        <div class="border-t-4 border-gray-700 border-x-4 rounded-t-xl bg-[#e075b5] p-4 md:flex grid">
            <div class="mx-4">
                <p class="text-center text-xl font-bold">Big Cute Banana</p>
                <p class="text-center mt-10">Sed aliquet erat dolor, vel suscipit dolor molestie nec. Mauris vitae condimentum metus. Fusce sit amet augue est. Aenean ut ornare quam. Duis sollicitudin ultricies imperdiet. Phasellus eu lorem magna. Donec eget purus non massa lobortis ullamcorper eget non sapien. Phasellus consectetur ligula in fringilla consequat. Curabitur vel auctor neque. Sed mauris erat, dapibus eget dictum at, volutpat sed justo.</p>
            </div>
            <!-- <div class="place-self-center mt-4"> -->
                <img class="border-2 border-black rounded-xl w-32 h-32 place-self-center mt-4" src="https://icon-library.com/images/banana-icon/banana-icon-5.jpg"/>
            <!-- </div> -->
        </div>
        <div class="border-b-4 border-gray-700 border-x-4 rounded-b-xl bg-[#f3a5d3] p-4 grid">
        <div> 
            <!-- Rendering multiple tags -->
            <div class="tooltip tooltip-bottom" data-tip="Something">
                <p class="badge badge-info font-bold p-3">Healthy</p>
            
            </div>
            <div class="tooltip tooltip-bottom" data-tip="Something">
                <p class="badge badge-info font-bold p-3">Healthy</p>
            </div>
        </div>
            <button class="btn btn-primary mt-4 place-self-center capitalize">
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