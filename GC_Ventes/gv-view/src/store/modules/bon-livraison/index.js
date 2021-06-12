// import Api from "../../api"
// const END_POINT = 'login';

import {BLs} from "../../../views/data"

const bonLivraison = {
    namespaced: true,
    state () {
        return {
            BLs
        }
    },
    getters: {
        getBLs: (state) => state.BLs
    },
    mutations: {
        setBLs: (state, payLoad) => state.BLs = payLoad,
    },
    actions: {
        initBLs: () => {
            console.log("initialise bon livraison");
        }
    }
};
export default bonLivraison