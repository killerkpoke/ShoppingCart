<script lang="ts">
import { defineComponent } from 'vue'
// import { ShoppingCart } from '~/types/ShoppingCart'
// import { Tag } from '~/types/Tag'

export default defineComponent({
  name: 'Indexpage',
 
  
  setup() {
    // const tag = withDefaults(defineProps<Tag>(), {
    //   Id:1,
    //   TagName: "Error",
    //   TagContext: "Danger"
    // })
    // const props = withDefaults(defineProps<ShoppingCart>(), {
    //   Id:1,
    //   ItemDescription:"Something item in type",
    //   ItemName: "Big Cute Banana",
    //   Quantity: 3,
    //   Tags: [tag]
    // })
    
    return {
      // dummydata: props
      dummydata : [
        {
          "id":1,
          "desc":"ItemDescription",
          "name":"Big Cute Banana",
          "quantity":3,
          "price":400,
          "tags":[{
              "id": 1,
              "name": "Error",
              "desc": "FATAL ERROR",
              "context": "error"
          }]
        },
        {
          "id":2,
          "desc":"ItemDescription",
          "name":"Big Cute Banana",
          "quantity":3,
          "price":600,
          "tags":[{
              "id": 1,
              "name": "Error",
              "desc": "FATAL ERROR",
              "context": "error"
          }]
        },
        {
          "id":3,
          "desc":"ItemDescription",
          "name":"Big Cute Banana",
          "quantity":3,
          "price":600,
          "tags":[{
              "id": 1,
              "name": "Error",
              "desc": "FATAL ERROR",
              "context": "error"
          }]
        },
        {
          "id":4,
          "desc":"ItemDescription",
          "name":"Big Cute Banana",
          "quantity":3,
          "price":600,
          "tags":[{
              "id": 1,
              "name": "Error",
              "desc": "FATAL ERROR",
              "context": "error"
          }]
        },
        {
          "id":5,
          "desc":"ItemDescription2",
          "name":"Little Cute Banana",
          "quantity":2,
          "price":700,
          "tags":[
            {
              "id": 1,
              "name": "Error",
              "desc": "FATAL ERROR",
              "context": "error"
            },
            {
              "id": 2,
              "name": "GTK",
              "desc": "Good to know",
              "context": "info"
            },
          ]
        },
      ]
    }
  },
})
</script>

<template>
  <div class="bg-red">
    <div class="navbar bg-base-100">
      <div class="flex-1">
        <button class="btn btn-square btn-ghost">
          <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" class="inline-block w-5 h-5 stroke-current"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 6h16M4 12h16M4 18h16"></path></svg>
        </button>
      </div>
      <div class="flex-auto justify-center">
        <h1 class="text-center font-bold text-5xl my-6 text-white">Emotional Fruit Shop</h1>
      </div>
      <div class="flex-1 justify-end">
        <div class="dropdown dropdown-end">
          <label tabindex="0" class="btn btn-ghost btn-square">
            <div class="indicator">
              <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" fill="none" viewBox="0 0 24 24" stroke="currentColor"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M3 3h2l.4 2M7 13h10l4-8H5.4M7 13L5.4 5M7 13l-2.293 2.293c-.63.63-.184 1.707.707 1.707H17m0 0a2 2 0 100 4 2 2 0 000-4zm-8 2a2 2 0 11-4 0 2 2 0 014 0z" /></svg>
              <!-- <span class="badge badge-sm indicator-item">{{ getCounter.count }}</span> -->
            </div>
          </label>
          <div tabindex="0" class="mt-3 card card-compact dropdown-content w-52 bg-base-100 shadow">
            <div class="card-body">
              <!-- <span class="font-bold text-lg">{{ getCounter.count }} Items</span> -->
              <span class="text-info">Subtotal: $999</span>
              <div class="card-actions">
                <button class="btn btn-primary btn-block">View cart</button>
              </div>
            </div>
          </div>
        </div>
      </div>
  </div>
  <div class="flex place-content-center ">
    <div>
      <div v-for="dum in dummydata" :key="dum.id">
        <Card :dummy="dum" />
      </div>
    </div>
  </div>
</div>
</template>