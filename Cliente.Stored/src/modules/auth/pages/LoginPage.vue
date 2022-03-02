<template>
  <div>
    <h1>{{ mensaje }}</h1>

    <form @submit.prevent="onSubmit()">
      <InputText type="text" v-model="login.username" placeholder="user name" />
      <InputText type="password" v-model="login.password" placeholder="password" />

      <Button type="submit" label="Entrar"/>
    </form>
  </div>
</template>

<script lang="ts">
import { computed, defineComponent, ref } from 'vue'
import { RespLogin } from '../models/auth'
import { useAuthStored } from '../../../stored/authStored'

export default defineComponent({
  setup () {
    const store = useAuthStored()

    const login = ref<RespLogin>({
      username:'',
      password:''
    })

    const onSubmit = () => {
      
    } 

    return { login, onSubmit, mensaje: computed(()=> store.mensaje) }
  }
})
</script>

<style scoped>

</style>