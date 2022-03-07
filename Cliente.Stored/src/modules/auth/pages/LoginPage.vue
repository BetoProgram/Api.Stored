<template>
  <div>
    <h1>{{ mensaje }}</h1>

    <form @submit.prevent="onSubmit()">
      <InputText type="text" v-model="login.Email" placeholder="Email" />
      <InputText type="password" v-model="login.Password" placeholder="password" />

      <Button type="submit" label="Entrar"/>
    </form>
  </div>
</template>

<script lang="ts">
import { computed, defineComponent, ref, onMounted } from 'vue'
import { useRouter } from 'vue-router'
import { RespLogin } from '../models/auth'
import { usePaths } from '../../../stored/cargaPaths'
import { useAuthStored } from '../../../stored/authStored'

export default defineComponent({
  setup () {
    const storePath = usePaths()
    const store = useAuthStored()
    const router = useRouter()

    const login = ref<RespLogin>({
      Email:'',
      Password:''
    })

    onMounted(()=>{
      storePath.obtenerPathApiCitas()
    })

    const onSubmit = () => {
      store.envioLogin(login.value)
      console.log(store.isLogin)
      if(store.isLogin){
        router.push({ name : 'home' })
      }
    }

    return { login, onSubmit, mensaje: computed(()=> store.mensaje) }
  }
})
</script>

<style scoped>

</style>