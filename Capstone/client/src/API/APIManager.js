import {createAuthHeaders} from './userManager';
const remoteUrl = '/api/';

export default {
    getData(resource) {
        const authHeader = createAuthHeaders()
        return fetch(`/api/${resource}`,
        {
            method: "GET",
            headers: authHeader
        })
            .then(response => response.json())
    },
    getWeekData(resource) {
        const authHeader = createAuthHeaders()
        return fetch(`/api/${resource}?week=true`,
        {
            method: "GET",
            headers: authHeader
        })
            .then(response => response.json())
    },
    getSpecificData(resource, id) {
        const authHeader = createAuthHeaders()
        return fetch(`/api/${resource}/${id}`,
        {
            method: "GET",
            headers: authHeader
        })
            .then(response => response.json())
    },
    postData(resource, newObj) {
        const authHeader = createAuthHeaders()
         return fetch(`${remoteUrl}${resource}`, {
            method: "POST",
            body: JSON.stringify(newObj),
            headers: {
                ...authHeader,
                Accept: 'application/json',
                'Content-Type': 'application/json',
              }, 
            
        }).then(response => response.json())
    },
    deleteUserData(resource, Id) {
        return fetch(`/api/${resource}/${Id}`, {
            method: "DELETE"
        })
            .then(response => response.json())
    },
    getQuotes(){
        const authHeader = createAuthHeaders()
        return fetch("http://quotes.rest/qod.json", {
            method: "GET"
        })
        .then(response => response.json())
    }
}