<template>
  <div id="app" class="container">
    <header>
      <h1 class="is-size-1">Grand Central Station</h1>
    </header>
    <div class="section">
      <div class="columns">
        <div class="column is-narrow">
          <h3 class="is-size-3">I want to provide feedback for</h3>
        </div>
        <div class="column">
          <div class="select is-medium">
            <!-- <select name="repos" id="repos" value="https://www.google.com"> -->
            <select v-model="selectedValue" name="repos" id="repos" @change="onChange($event)" >
              <option v-for="repo in repos" :key="repo.Url" v-bind:value="repo.Url"
                >{{ repo.Name }} 
              </option>
            </select>
          </div>
        </div>
      </div>
    </div>
    <div class="section">

      <div id="app">
        <h3 class="is-size-3">I want to add a repo</h3>
        <div v-for="repo in repos" :key="repo.Url"> 
          <input v-model="repo.Name">
          <input v-model="repo.Url">
          <input v-model="repo.Notes">
        </div>
        
        <button @click="addUser">
          Add repo!
        </button>
        
        <pre>{{ $data }}</pre>
      </div>

    </div>
  </div>
</template>

<script>
import axios from "axios";

export default {
  name: "App",
  data() {
    return {
      repos: []
    };
  },
  methods: {
    addUser: function () {
      this.repos.push({ Name: '',Url:'',Notes:'' });
    },
    onChange(event) {
      console.log(event.target.value);
        window.location.href = event.target.value;}
  },
  mounted: async function() {
    const response = await axios.get(`${process.env.VUE_APP_API_BASE}/repos`);
    this.repos = response.data;
  }
};
</script>

<style></style>
