// import { defineStore } from 'pinia'
// export const useCounterStore = defineStore({
//   id:'counter',
//   state: () => ({
//     count: 0,
//   }),
//   getters:{
//     count: (state) => state.count
//   },
//   actions: {
//     Increment() {
//       this.count++
//     }
//   }
// })


export const state = () => ({
  fruits: []
})

export const mutations = {
	addFruit(state: { fruits: any[] }, fruit: any) {
		state.fruits.push(fruit)
	},
	removeFruit(state: { fruits: any[] }, fruitId: any) {
		state.fruits = state.fruits.filter((fruit) => fruit.id !== fruitId)
	},
}

export const getters = {
	getApples: (state: { fruits: any[] }) => {
		return state.fruits.filter((fruit) => fruit.type === 'Apple')
	},
}
