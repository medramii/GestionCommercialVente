import Api from "../../api"

const END_POINT = 'WebDroitUsers/GroupAccessRights/';

const groupsAccessRights = {
    namespaced: true,
    state () {
        return {
            groups: [],
            accessRights: [],
            selectedGroup: []
        }
    },
    getters: {
        getGroups: (state) => state.groups,
        getAccessRights: (state) => state.accessRights,
        getSelectedGroup: (state) => state.selectedGroup,
    },
    mutations: {
        setGroups: (state, payLoad) => state.groups = payLoad,
        setAccessRights: (state, payLoad) => state.accessRights = payLoad,
        setSelectedGroup: (state, payLoad) => state.selectedGroup = payLoad,
    },
    actions: {
        GetGroupAccessRights: ({commit}, payload) => {
            let rights = [];
            let grp = [];
            return new Promise((resolve, reject) => {
                Api.get(END_POINT + payload)
                .then((response) => {
                    response.data.forEach(e => {
                        var right = {
                            "Id": e.idPageNavigation.id,
                            "Page": e.idPageNavigation.page,
                            "Has access ??": e.droit,
                        }
                        rights.push(right);
                        grp.push({
                            "id": e.id,
                            "idGoup": e.idGoup,
                            "idGoupNavigation": e.idGoupNavigation,
                            "idPageNavigation": e.idPageNavigation/****************** */
                        })
                    });
                    commit("setAccessRights", rights);
                    commit("setSelectedGroup", grp);
                    resolve(response);
                })
                .catch((error) => reject(error));
            })
        },
        
        GetGroups: ({commit}) => {
            let grps = [];
            return new Promise((resolve, reject) => {
                Api.get("MdiGroupeUtilisateurs")
                .then((response) => {
                    response.data.forEach(e => {
                        grps.push(e.designation);
                    });
                    commit("setGroups", grps);
                    resolve(response);
                })
                .catch((error) => reject(error));
            })
        }
    }
};
export default groupsAccessRights