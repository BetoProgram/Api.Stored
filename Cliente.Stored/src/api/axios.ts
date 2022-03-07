import axios, { AxiosRequestConfig } from 'axios'
import router from '../router'

const axiosClient = axios.create({
  baseURL: localStorage.getItem('pathApi')?.toString(),
  headers: {
    'Content-Type': 'application/json'
  }
})

axiosClient.interceptors.request.use(
  (request:AxiosRequestConfig) => {
    request.headers = {
      'Authorization': `Bearer ${localStorage.getItem('token')}`,
      'Accept': 'application/json',
      'Content-Type': 'application/json'
    }

    return request;
  },
  error=>{
    Promise.reject(error)
  }
)

axiosClient.interceptors.response.use(response => {
  return response
}, error=> {
  if(error.response.status === 401){
    localStorage.removeItem('token')
    router.push({ name: 'login' })
  }else if (error.response.status === 404){
    router.push({ name : 'notfound' })
  }
  throw error
})

export default axiosClient