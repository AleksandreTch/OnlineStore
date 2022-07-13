import axios, { AxiosError, AxiosResponse } from "axios";


axios.defaults.baseURL = 'http://localhost:5000/api/';
axios.defaults.withCredentials = true;

const resposeBody = (response: AxiosResponse) => response.data;


const requests = {
    get: (url: string) => axios.get(url).then(resposeBody),
    post: (url: string, body: {}) => axios.post(url, body).then(resposeBody),
    put: (url: string, body: {}) => axios.put(url, body).then(resposeBody),
    delete: (url: string) => axios.delete(url).then(resposeBody),
}

const Catalog = {
    list: () => requests.get('products'),
    details: (id: number) => requests.get(`products/${id}`)
}

const TestErrors = {
    get400Error: () => requests.get('buggy/bad-request'),
    get401Error: () => requests.get('buggy/unauthorised'),
    get404Error: () => requests.get('buggy/not-found'),
    get500Error: () => requests.get('buggy/server-error'),
    getValidationError: () => requests.get('buggy/validation-error'),
}



const Basket = {
    get: () => requests.get('basket'),
    addItem: (productId: number, quantity = 1) => requests.post(`basket?productId=${productId}&quantity=${quantity}`, {}),
    removeItem: (productId: number, quantity = 1) => requests.delete(`basket?productId=${productId}&quantity=${quantity}`)
}

const agent = {
    Catalog,
    TestErrors,
    Basket
}

export default agent;