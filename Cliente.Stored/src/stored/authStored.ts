import { defineStore } from 'pinia'
import axiosClient from '../api/axios'
import { RespLogin } from '../modules/auth/models/auth'


export const useAuthStored = defineStore('authStored',{
  state: () => {
    return { 
      mensaje: 'Acceso a Aplicación',
      token: '',
      error: [],
      isLogin: false
    }
  },
  actions:{
    envioLogin(login:RespLogin) {
      return axiosClient.post('Auth/Login', login)
      .then(res=>{
        this.token = res.data.token
        localStorage.setItem('token', this.token)
        this.isLogin = true
      }).catch(err => {
        this.error = err.response.errors
        this.isLogin = false
      })
    }
  }
})