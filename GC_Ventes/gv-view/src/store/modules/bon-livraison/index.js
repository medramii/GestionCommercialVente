import Api from "../../api"
const END_POINT = 'BonLivraison/';

// import {BLs} from "../../../views/data"

const bonLivraison = {
    namespaced: true,
    state () {
        return {
            BLs: [],
            BlInUse: [],
        }
    },
    getters: {
        getBLs: (state) => state.BLs,
        getBlInUse: (state) => state.BlInUse,
    },
    mutations: {
        setBLs: (state, payLoad) => state.BLs = payLoad,
        setBlInUse: (state, payLoad) => state.BlInUse = payLoad,
    },
    actions: {
        initBLs: ({commit}) => {
            return new Promise((resolve, reject) => {
                Api.get(END_POINT)
                .then((response) => {
                    commit("setBLs", response.data);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        deleteBL: ({commit}, payLoad) => {
            console.log(!!commit);
            console.log(payLoad);
            return new Promise((resolve, reject) => {
                Api.delete(END_POINT + payLoad)
                .then((response) => {
                    resolve(response);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        addBL: () => {

            console.log(this.BlInUse);

            // return new Promise((resolve, reject) => {
            //     Api.post(END_POINT, state.BlInUse)
            //     .then((response) => {
            //         resolve(response);
            //     })
            //     .catch((error) => {
            //         reject(error);
            //     });
            // });
        }
    }
};
export default bonLivraison