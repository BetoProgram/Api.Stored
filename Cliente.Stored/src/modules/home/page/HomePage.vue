<template>
  <div>
    <h1>Pagina Principal</h1>
    <Button label="Primary" value="Prueba" />
  </div>
</template>

<script lang="ts">
import { defineComponent, onMounted, ref } from 'vue'
import HomeService  from '../services/HomeService'

export default defineComponent({
  setup () {

    const homeService = ref(new HomeService())
    
    onMounted(() => {
      console.log('pagina homes')
      homeService.value.getPacientes().then(res=> {
        console.log(res)
      })
    })

    return {}
  }
})
</script>

<style scoped>

</style>