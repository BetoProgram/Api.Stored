import { defineStore } from 'pinia'

export const useAuthStored = defineStore('authStored',{
  state: () => {
    return { mensaje: 'Acceso a Aplicación' }
  }
})