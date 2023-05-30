<template>
    <div>
        <Header>
        </Header>
        <div class="flex place-content-center">
            <form method="POST">
                <div class="form-control w-full max-w-xs">
                    <label class="label">
                        <span class="label-text">Item name</span>
                    </label>
                    <input type="text" class="input w-full max-w-xs bg-white text-black" />
                </div>
                <div class="form-control w-full max-w-xs">
                    <label class="label">
                        <span class="label-text">Item price</span>
                    </label>
                    <input type="number" class="input w-full max-w-xs bg-white text-black" />
                </div>
                <div class="form-control w-full max-w-xs">
                    <label class="label">
                        <span class="label-text">Item quantity</span>
                    </label>
                    <input type="number" class="input w-full max-w-xs bg-white text-black" />
                </div>
                <div class="form-control w-full max-w-xs">
                    <label class="label">
                        <span class="label-text">Item image</span>
                    </label>
                    <input type="file" class="file-input file-input-bordered w-full max-w-xs" />
                </div>
                <button class="btn btn-primary mt-6">
                    <!-- <NuxtLink to="/manageview"> -->
                        Create Item
                    <!-- </NuxtLink> -->
                </button>
            </form>
        </div>
    </div>
</template>