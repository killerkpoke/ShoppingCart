<script setup lang="ts">
import { Form, Field, ErrorMessage, defineRule  } from 'vee-validate';

defineRule('required', (value: string | any[]) => {
  if (!value || !value.length) {
    return 'This field is required';
  }
  return true;
});



function onSubmit(values: object) {
  // Submit values to API...
  alert(JSON.stringify(values, null, 2));
}

</script>


<template>
    <div>
        <Header>
        </Header>
        <div class="flex place-content-center">
            <Form method="POST"  @submit="onSubmit">
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
                    <Field name="price" type="number" rules="required" class="input w-full max-w-xs bg-white text-black" ></Field>
                    <ErrorMessage name="price" class="text-red-500" />
                </div>
                <div class="form-control w-full max-w-xs">
                    <label class="label">
                        <span class="label-text">Item quantity</span>
                    </label>
                    <Field name="quantity" type="number" rules="required" class="input w-full max-w-xs bg-white text-black" ></Field>
                    <ErrorMessage name="quantity" class="text-red-500" />
                </div>
                <div class="form-control w-full max-w-xs">
                    <label class="label">
                        <span class="label-text">Item image</span>
                    </label>
                    <Field name="file" type="file" rules="required" class="file-input file-input-bordered w-full max-w-xs" ></Field>
                    <ErrorMessage name="file" class="text-red-500" />
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