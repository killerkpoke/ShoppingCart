<script lang="ts">
import { defineComponent } from 'vue'

export default defineComponent({
  name: 'Indexpage',
 
  setup() {
    return {
      dummydata : [
        {
          "id":1,
          "desc":"ItemDescription",
          "name":"ItemName",
          "quantity":3,
          "tags":[{
              "id": 1,
              "name": "Error",
              "context": "danger"
          }]
        },
        {
          "id":2,
          "desc":"ItemDescription2",
          "name":"ItemName2",
          "quantity":2,
          "tags":[{
              "id": 1,
              "name": "Error",
              "context": "danger"
          }]
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