export const useCounter = () => useState<number>('counter', () => 0)
export const usePrice = () => useState<number>('price', () => 0)
export const useSelectedItems = () => useState<Array<object>>('selectedItems', () => [])
