import { defineStore } from 'pinia'
import axios from 'axios'

export const usePaths = defineStore('cargaPaths',{
  state: () => {
    return { url: '' }
  },
  actions: {
    obtenerPathApiCitas(){
      axios.get('assets/data/path_apis.json').then((res:any) => {
        this.url = res.data.PathDev.citas
        localStorage.setItem('pathApi', this.url)
        console.log(this.url)
      })
    }
  }
})