import axiosClient from '../../../api/axios'

export default class HomeService {


  getPacientes(){
    return axiosClient.get('/PacientesCat')
  }

}