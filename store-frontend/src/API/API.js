import axios from 'axios';

const BASE_URL = 'http://localhost:5043/'
export const getAllProduct =() =>{
    return axios.get(`${BASE_URL}api/product`)
}
export const SignUp =(user) =>{
    return axios.post(`${BASE_URL}api/User`, user)
}

export const SignIn =(user) =>{
    return axios.post(`${BASE_URL}api/User/login`, user)
}