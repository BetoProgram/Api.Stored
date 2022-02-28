<template>
  <div>
    <Menubar :model="items">
			<template #start>
				<img alt="logo" src="https://www.primefaces.org/wp-content/uploads/2020/05/placeholder.png" height="40" class="mr-2">
			</template>
			<template #end>
				<InputText placeholder="Buscar" type="text" />
			</template>
		</Menubar>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref } from 'vue'

export default defineComponent({
  setup () {
    const items = ref([]);

    return { items }
  }
})
</script>

<style scoped>

</style>