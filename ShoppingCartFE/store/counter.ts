import { defineStore } from 'pinia'
export const useCounterStore = defineStore({
  id:'counter',
  state: () => ({
    count: 0,
  }),
  actions: {
    Increment(count: number) {
      this.count += count;
    }
  }
})


