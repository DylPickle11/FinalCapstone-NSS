const remoteUrl = 'http://localhost:5001/api/';

export default {
    getUserData() {
        return fetch(`/api/CheckIns`)
            .then(response => response.json())
    },
    getData(resource) {
        return fetch(`/api/${resource}`)
            .then(response => response.json())
    },
    getSpecificData(resource, id) {
        return fetch(`/api/${resource}/${id}`)
            .then(response => response.json())
    },
    postData(resource, newObj) {
         return fetch(`${remoteUrl}${resource}`, {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(newObj)
        }).then(response => response.json())
    },
    deleteUserData(resource, Id) {
        return fetch(`/api/${resource}/${Id}`, {
            method: "DELETE"
        })
            .then(response => response.json())
    }
}