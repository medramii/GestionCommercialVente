const testModule = {
  namespaced: true,
  state () {
    return {
      msg: "Welcome to store"
    }
  },
  getters: {
    getMsg: (state) => state.msg,
  },
  mutations: {
    upperCase: (state) => state.msg = state.msg.toUpperCase(),
    lowerCase: (state) => state.msg = state.msg.toLowerCase(),
    concat: (state, payLoad) => state.msg = state.msg.concat(payLoad.txt),
  },
  actions: {
    uppAfterDelai: ({commit}) => {
      setTimeout(() => {
        commit('upperCase');
      }, 1000)
    }
  }
};
export default testModule