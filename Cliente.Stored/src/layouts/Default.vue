<template>
  <div>
    <MenuBar/>
    <div class="layout-main">
      <slot />
		</div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue'
import MenuBar from '../modules/shared/components/MenuBar.vue'

export default defineComponent({
  components:{
    MenuBar
  },
  setup () {
    

    return {}
  }
})
</script>

<style scoped>

</style>