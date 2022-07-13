import axios, { AxiosError, AxiosResponse } from "axios";
import { toast } from "react-toastify";

axios.defaults.baseURL = 'http://localhost:5000/api/';

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

const agent = {
    Catalog,
    TestErrors
}

export default agent;