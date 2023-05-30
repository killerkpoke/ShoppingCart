<script setup lang="ts">
import { Form, Field, ErrorMessage } from 'vee-validate';




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
                    <Field name="name" type="text" class="input w-full max-w-xs bg-white text-black" ></Field>
                    <ErrorMessage name="name" />
                </div>
                <div class="form-control w-full max-w-xs">
                    <label class="label">
                        <span class="label-text">Item price</span>
                    </label>
                    <Field name="price" type="number" class="input w-full max-w-xs bg-white text-black" ></Field>
                    <ErrorMessage name="price" />
                </div>
                <div class="form-control w-full max-w-xs">
                    <label class="label">
                        <span class="label-text">Item quantity</span>
                    </label>
                    <Field name="quantity" type="number" class="input w-full max-w-xs bg-white text-black" ></Field>
                    <ErrorMessage name="quantity" />
                </div>
                <div class="form-control w-full max-w-xs">
                    <label class="label">
                        <span class="label-text">Item image</span>
                    </label>
                    <Field name="file" type="file" class="file-input file-input-bordered w-full max-w-xs" ></Field>
                    <ErrorMessage name="file" />
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