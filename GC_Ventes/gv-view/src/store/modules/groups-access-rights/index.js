import Api from "../../api"

const MAIN_END_POINT = 'WebDroitUsers/';
const GROUPS_END_POINT = 'MdiGroupeUtilisateurs/';
const RIGHTS_END_POINT = 'WebDroitUsers/GroupAccessRights/';

const groupsAccessRights = {
    namespaced: true,
    state () {
        return {
            groups: [],
            accessRights: [],
        }
    },
    getters: {
        getGroups: (state) => state.groups,
        getAccessRights: (state) => state.accessRights,
    },
    mutations: {
        setGroups: (state, payLoad) => state.groups = payLoad,
        setAccessRights: (state, payLoad) => state.accessRights = payLoad,
    },
    actions: {
        GetGroups: ({commit}) => {
            let tmpGroups = [];
            return new Promise((resolve, reject) => {
                Api.get(GROUPS_END_POINT)
                .then((response) => {
                    response.data.forEach(e => {
                        tmpGroups.push({
                            "id": e.id,
                            "name": e.designation
                        });
                    });
                    commit("setGroups", tmpGroups);
                    resolve(response);
                })
                .catch((error) => reject(error));
            })
        },
        GetGroupAccessRights: ({commit}, payload) => {
            let rights = [];
            return new Promise((resolve, reject) => {
                Api.get(RIGHTS_END_POINT + payload)
                .then((response) => {
                    response.data.forEach(e => {
                        var right = {
                            "id": e.id,
                            "idGoup": e.idGoup,
                            "idPage": e.idPageNavigation.id,
                            "Page": e.idPageNavigation.page,
                            "hasAccess": e.droit,
                        }
                        rights.push(right);
                    });
                    commit("setAccessRights", rights);
                    resolve(response);
                })
                .catch((error) => reject(error));
            })
        },
        UpdateGroupAccessRights: ({commit}, payload) => {
            //console.log(!!commit);
            return new Promise((resolve, reject) => {
                Api.put(MAIN_END_POINT + payload.id, payload.data)
                .then(() => {
                    resolve(commit);
                })
                .catch((error) => reject(error));
            })
        },
        
    }
};
export default groupsAccessRights