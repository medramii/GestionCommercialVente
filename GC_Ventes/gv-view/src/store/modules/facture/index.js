import Api from "../../api"
const MAIN_END_POINT = 'Facture/';

const bonLivraison = {
    namespaced: true,
    state () {
        return {
            Factures: [],
            FactureInUse: [],
            Livraisons: [],
            NextFacture: "",
        }
    },
    getters: {
        getFactures: (state) => state.Factures,
        getFactureInUse: (state) => state.FactureInUse,
        getLivraisons: (state) => state.Livraisons,
        getNextFacture: (state) => state.NextFacture,
    },
    mutations: {
        setFactures: (state, payLoad) => state.Factures = payLoad,
        setFactureInUse: (state, payLoad) => state.FactureInUse = payLoad,
        setLivraisons: (state, payLoad) => state.Livraisons = payLoad,
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
        /* -------------- for crud operations ------------------ */
        // for delete
        deleteFacture: ({commit}, id) => {
            console.log(!!commit);
            console.log(id);
            return new Promise((resolve, reject) => {
                Api.delete(MAIN_END_POINT + id)
                .then((response) => {
                    resolve(response);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        // refresh livraisons
        refreshLivraisons: ({commit}, payload) => {
            return new Promise((resolve, reject) => {
                Api.get(MAIN_END_POINT + "Livraisons/" + payload.idFac + "/" + payload.codeClient + "/" + payload.dateFac)
                .then((response) => {
                    commit("setLivraisons", response.data);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        //for add
        initDataForAdd: ({commit}) => {
            return new Promise((resolve, reject) => {
                // get next numFacture
                Api.get(MAIN_END_POINT + "NextFacture")
                .then((response) => {
                    commit("setNextFacture", response.data);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        addFacture: ({getters}) => {
            let facture = {
                "numFac": getters.getFactureInUse.numFacture,
                "dateFac": getters.getFactureInUse.dateFacture,
                "dateEcheance": getters.getFactureInUse.dateEcheance,
                "codeClient": getters.getFactureInUse.client,
                "codeModeReg": getters.getFactureInUse.modeReglement,
                "observation": getters.getFactureInUse.observation,
                "idDevise": getters.getFactureInUse.devise,
                "tauxDeChange": getters.getFactureInUse.tauxDeChange,
                "montantDh": getters.getFactureInUse.montantDh,
                "montantDevise": getters.getFactureInUse.montantDevise,
            };
            let livraisons = [];
            getters.getLivraisons.forEach(e => {
                if (e.facture) livraisons.push(e.id);
            });

            return new Promise((resolve, reject) => {
                Api.post(MAIN_END_POINT, {facture, livraisons})
                .then((response) => {
                    resolve(response);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        //for edit
        initDataForUpdate: ({commit}, id) => {
            return new Promise((resolve, reject) => {
                Api.get(MAIN_END_POINT + id)
                .then((response) => {
                    commit("setFactureInUse", response.data[0]);
                    commit("setNextFacture", response.data[0].numFac);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        // edit facture
        editFacture: ({getters}, id) => {
            console.log(getters.getFactureInUse.devise);
            let facture = {
                "Id": id,
                "numFac": getters.getFactureInUse.numFacture,
                "dateFac": getters.getFactureInUse.dateFacture,
                "dateEcheance": getters.getFactureInUse.dateEcheance,
                "codeClient": getters.getFactureInUse.client,
                "codeModeReg": getters.getFactureInUse.modeReglement,
                "observation": getters.getFactureInUse.observation,
                "idDevise": getters.getFactureInUse.devise,
                "tauxDeChange": getters.getFactureInUse.tauxDeChange,
                "montantDh": getters.getFactureInUse.montantDh,
                "montantDevise": getters.getFactureInUse.montantDevise,
            };
            let livraisons = [];
            getters.getLivraisons.forEach(e => {
                if (e.facture) livraisons.push(e.id);
            });
            console.log({facture, livraisons});
            return new Promise((resolve, reject) => {
                Api.put(MAIN_END_POINT + id, {facture, livraisons})
                .then((response) => {
                    resolve(response);
                })
                .catch((error) => {
                    console.log("error........");
                    reject(error);
                });
            });

        },
        // for print
        getFactureById: ({commit}, id) => {
            console.log(!!commit);
            console.log(id);
            return new Promise((resolve, reject) => {
                Api.get(MAIN_END_POINT + id)
                .then((response) => {
                    resolve(response);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
    }
    
};
export default bonLivraison