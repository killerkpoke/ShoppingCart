<script setup lang="ts">
    // const dummydata = [
    //     {
    //         "id":1,
    //         "desc":"ItemDescription",
    //         "name":"Big Cute Banana",
    //         "quantity":3,
    //         "price":400,
    //         "tags":[{
    //             "id": 1,
    //             "name": "Error",
    //             "desc": "FATAL ERROR",
    //             "context": "error"
    //         }]
    //     },
    //     {
    //         "id":2,
    //         "desc":"ItemDescription",
    //         "name":"Big Cute Banana",
    //         "quantity":3,
    //         "price":600,
    //         "tags":[{
    //             "id": 1,
    //             "name": "Error",
    //             "desc": "FATAL ERROR",
    //             "context": "error"
    //         }]
    //     },
    //     {
    //         "id":3,
    //         "desc":"ItemDescription",
    //         "name":"Big Cute Banana",
    //         "quantity":3,
    //         "price":600,
    //         "tags":[{
    //             "id": 1,
    //             "name": "Error",
    //             "desc": "FATAL ERROR",
    //             "context": "error"
    //         }]
    //     },
    //     {
    //         "id":4,
    //         "desc":"ItemDescription",
    //         "name":"Big Cute Banana",
    //         "quantity":3,
    //         "price":600,
    //         "tags":[{
    //             "id": 1,
    //             "name": "Error",
    //             "desc": "FATAL ERROR",
    //             "context": "error"
    //         }]
    //     },
    //     {
    //         "id":5,
    //         "desc":"ItemDescription2",
    //         "name":"Little Cute Banana",
    //         "quantity":2,
    //         "price":700,
    //         "tags":[
    //         {
    //             "id": 1,
    //             "name": "Error",
    //             "desc": "FATAL ERROR",
    //             "context": "error"
    //         },
    //         {
    //             "id": 2,
    //             "name": "GTK",
    //             "desc": "Good to know",
    //             "context": "info"
    //         },
    //         ]
    //     },
    // ]

    const localData = localStorage.getItem('newItem') || "{}";
    const data = JSON.parse(localData);
    
</script>
<template>
    <div class="min-h-screen">
        <Header></Header>
        <div class="flex place-content-center">
            <div>
                <div v-for="dum in data" :key="dum.id">
                    <Card :dummy="dum" />
                </div>
            </div>
        </div>
        <Footer></Footer>
    </div>
</template>