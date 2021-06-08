import Vue from 'vue'
import Vuex from 'vuex'
import axios from 'axios'

Vue.use(Vuex)

export default new Vuex.Store({
  
  // 1. hämta saker från apiet
  actions: {
    getDevices: async ({commit}) => {
      const res = await axios.get('http://localhost:7071/api/devices')

      if(res.status === 200)
        commit('SET_DEVICES', res.data)
    },

    toggleSendData: async ({commit}, item) => {
      let command = (item.properties.reported.sending) ? 'stop' : 'start'
      
      commit('TOGGLE_STATE_PENDING', true)
      const res = await axios.get(`http://localhost:7071/api/method?deviceid=${item.deviceId}&command=${command}`)
    
      if(res.status === 200)
        commit('TOGGLE_STATE_PENDING', false)
      
    }
  },

  // 2. lägg in saker i state från apiet
  mutations: {
    SET_DEVICES: (state, payload) => {
      state.devices = payload
    },

    TOGGLE_STATE_PENDING: (state, payload) => {
      state.toggleStatePending = payload
    }

  },

  // 3. här har vi nu alla värden
  state: {
    devices: [],
    toggleStatePending: true
  },

  // 4. hämta saker från vår state
  getters: {
    devices: state => state.devices
  }






})
