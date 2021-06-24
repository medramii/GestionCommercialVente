import Api from "../../api"
const MAIN_END_POINT = 'Facture/';

const bonLivraison = {
    namespaced: true,
    state () {
        return {
            Factures: [],
            FactureInUse: [],
            LignesFacture: [],
            NextFacture: "",
        }
    },
    getters: {
        getFactures: (state) => state.Factures,
        getFactureInUse: (state) => state.FactureInUse,
        getLignesFacture: (state) => state.LignesFacture,
        getNextFacture: (state) => state.NextFacture,
    },
    mutations: {
        setFactures: (state, payLoad) => state.Factures = payLoad,
        setFactureInUse: (state, payLoad) => state.FactureInUse = payLoad,
        setLignesFacture: (state, payLoad) => state.LignesFacture = payLoad,
        setNextFacture: (state, payLoad) => state.NextFacture = payLoad,
    },
    actions: {
        initFactures: ({commit}) => {
            return new Promise((resolve, reject) => {
                Api.get(MAIN_END_POINT)
                .then((response) => {
                    commit("setFactures", response.data);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        
        
    }
    
};
export default bonLivraison