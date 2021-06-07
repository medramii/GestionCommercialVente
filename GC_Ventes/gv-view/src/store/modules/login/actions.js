import Api from "../../api"

const END_POINT = 'login';

const actions = {
    Login: ({ commit }, creds) => {
        return new Promise((resolve, reject) => {            
            Api.post(END_POINT, creds)
            .then((response) => {
                localStorage.setItem("UserToken", response.data.token);
                localStorage.setItem("User", JSON.stringify(response.data.currentUser));
                commit("setSignedUser", response.data.currentUser);
                Api.defaults.headers.common['Authorization'] = `Bearer ${response.data.token}`;
                resolve(response.data);
            })
            .catch((error) => reject(error));
        })
    },
    Logout: ({ commit }) => {
        localStorage.removeItem('User');
        localStorage.removeItem('UserToken');
        commit("setSignedUser", null);
    }
};
export default actions