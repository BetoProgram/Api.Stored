    

<template>
  <component :is="layout">
    <router-view/>
  </component>
</template>

<script lang="ts">
  import { defineComponent, computed } from 'vue'
  import { useRoute } from 'vue-router'
  
  export default defineComponent({
    setup () {
      const route = useRoute();
      const defaultLayout:string = 'default';
      const layout = computed(()=> (route.meta.layout || defaultLayout) + '-layout')

      return { layout }
    }
  })
</script> 

<style>

</style>
