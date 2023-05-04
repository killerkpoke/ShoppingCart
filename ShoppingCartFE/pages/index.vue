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
          "tags":[{
              "id": 1,
              "name": "Error",
              "desc": "FATAL ERROR",
              "context": "error"
          }]
        },
        {
          "id":2,
          "desc":"ItemDescription2",
          "name":"Little Cute Banana",
          "quantity":2,
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
  }
})
</script>

<template>
  <div class="flex place-content-center ">
    <div>
      <h1 class="text-center font-bold text-5xl my-6 text-white">Emotional Fruit Shop</h1>
      <div v-for="dum in dummydata" :key="dum.id">
        <Card :dummy="dum" />
      </div>
    </div>
  </div>
</template>