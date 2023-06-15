<script setup lang="ts">
import { Form, Field, ErrorMessage, defineRule  } from 'vee-validate';
import { useToast, POSITION  } from "vue-toastification";

let fruitList = useFruit();
let userImage: any = null;

defineRule('required', (value: string | any[]) => {
  if (!value || !value.length) {
    return 'This field is required';
  }
  return true;
});
defineRule('minLength', (value: string | any[], [limit]: any) => {
  if (!value || !value.length) {
    return true;
  }
  if (value.length < limit) {
    return `This field must be at least ${limit} characters`;
  }
  return true;
});

function onFileChange(e: any) {
    let files = e.target.files || e.dataTransfer.files;
    if (!files.length) {
      return
    }
    createImage(files[0]);
}
function createImage(file: any) {
    const reader = new FileReader()
    reader.onload = (e) => {
        userImage = e.target?.result
        localStorage.setItem('newItemImg', userImage);
    }
    reader.readAsDataURL(file)  
}
function onSubmit(values: any) {
    const item: Fruit = {
            id: Math.ceil(Math.random()*1000000),
        name: values.name,
        price: values.price,
        quantity: values.quantity,
        image: values.image
    }    
    
    fruitList.value.unshift(item);
    localStorage.setItem('newItem', JSON.stringify(fruitList.value, null, 2)); 
    const toast = useToast();
    toast.success("Created an item successfully!", {
        timeout: 3000,
        position: POSITION.BOTTOM_RIGHT,
    });
}
</script>
<template>
    <div>
        <Header>
        </Header>
        <div class="flex place-content-center">
            <Form method="POST" @submit="onSubmit">
                <div class="form-control w-full max-w-xs">
                    <label class="label">
                        <span class="label-text">Item name</span>
                    </label>
                    <Field name="name" type="text" rules="required" class="input w-full max-w-xs bg-white text-black" ></Field>
                    <ErrorMessage name="name" class="text-red-500" />
                </div>
                <div class="form-control w-full max-w-xs">
                    <label class="label">
                        <span class="label-text">Item price</span>
                    </label>
                    <Field name="price" type="number" rules="required|minLength:3" class="input w-full max-w-xs bg-white text-black" ></Field>
                    <ErrorMessage name="price" class="text-red-500" />
                </div>
                <div class="form-control w-full max-w-xs">
                    <label class="label">
                        <span class="label-text">Item quantity</span>
                    </label>
                    <Field name="quantity" type="number" rules="required|minLength:3" class="input w-full max-w-xs bg-white text-black" ></Field>
                    <ErrorMessage name="quantity" class="text-red-500" />
                </div>
                <div class="form-control w-full max-w-xs">
                    <label class="label">
                        <span class="label-text">Item image</span>
                    </label>
                    <Field name="file" type="file" @change="onFileChange" class="file-input file-input-bordered w-full max-w-xs" ></Field>
                    <img class="mt-6" :src="userImage" />
                </div>
                <button class="btn btn-primary mt-6">
                    <!-- <NuxtLink to="/manageview"> -->
                        Create Item
                    <!-- </NuxtLink> -->
                </button>
            </Form>
        </div>
    </div>
</template>