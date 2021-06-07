import getters from "./getters"
import mutations from "./mutations"
import actions from "./actions"

const login = {
    namespaced: true,
    state () {
        return {
            signedUser: JSON.parse(localStorage.getItem("User")) || null
        }
    },
    getters,
    mutations,
    actions
};
export default login