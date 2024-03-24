import axios from 'axios';
const postLogin = (email, password) => {
    return axios.post(`https://localhost:7214/api/User/Login`, { email, password })
}
export {
    postLogin
}