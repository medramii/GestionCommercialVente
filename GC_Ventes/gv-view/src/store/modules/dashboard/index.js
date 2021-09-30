import Api from "../../api"
const END_POINT = 'Dashboard/';

const dashboard = {
    namespaced: true,
    state () {
        return {
            Ventes: [],
            Total: [],
            Livraisons: [],
            TopDestinations: [],
            TopClients: [],
        }
    },
    getters: {
        getVentes: (state) => state.Ventes,
        getTotal: (state) => state.Total,
        getLivraisons: (state) => state.Livraisons,
        getTopDestinations: (state) => state.TopDestinations,
        getTopClients: (state) => state.TopClients,
    },
    mutations: {
        setVentes: (state, payLoad) => state.Ventes = payLoad,
        setTotal: (state, payLoad) => state.Total = payLoad,
        setLivraisons: (state, payLoad) => state.Livraisons = payLoad,
        setTopDestinations: (state, payLoad) => state.TopDestinations = payLoad,
        setTopClients: (state, payLoad) => state.TopClients = payLoad,
    },
    actions: {
        initVentes: ({commit}, year) => {
            let tLocal = 0;
            let tExport = 0;
            return new Promise((resolve, reject) => {
                Api.get(END_POINT + "Ventes/" + year)
                .then((response) => {
                    response.data.forEach(el => {
                        tLocal += el.local || 0;
                        tExport += el.export || 0;
                    });
                    
                    let total = [
                        {
                            type: 'Local',
                            montant: tLocal.toFixed(2)
                        },
                        {
                            type: 'Export',
                            montant: tExport.toFixed(2)
                        }
                    ];

                    commit("setVentes", response.data);
                    commit("setTotal", total);

                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        initLivraisons: ({commit}, date) => {
            let nfData = {
                facture: "Non Facturé",
                count: 0
            };
            let fData = {
                facture: "Facturé",
                count: 0
            };
            return new Promise((resolve, reject) => {
                Api.get(END_POINT + "Livraisons/" + date.start + "/" + date.end)
                .then((response) => {
                    response.data.forEach(el => {
                        if (el.facture == "Non Facturé") {
                            nfData = el;
                        } else {
                            fData.count += el.count;
                        }
                    });
                    commit("setLivraisons", [fData, nfData]);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        initTopDestinations: ({commit}, date) => {
            return new Promise((resolve, reject) => {
                Api.get(END_POINT + "TopDestinations/" + date.start + "/" + date.end)
                .then((response) => {
                    const top = response.data.slice(0,20);
                    commit("setTopDestinations", top);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        initTopClients: ({commit}, date) => {
            return new Promise((resolve, reject) => {
                Api.get(END_POINT + "TopClients/" + date.start + "/" + date.end)
                .then((response) => {
                    const top = response.data.slice(0,10);
                    commit("setTopClients", top);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
    }
};
export default dashboard