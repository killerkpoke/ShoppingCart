import { defineStore } from 'pinia'
export const useCounterStore = defineStore({
  id:'counter',
  state: () => ({
    count: 0,
  }),
  getters:{
    count: (state) => state.count
  },
  actions: {
    Increment() {
      this.count++
    }
  }
})


