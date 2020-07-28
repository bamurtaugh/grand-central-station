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
            <select name="repos" id="repos">
              <option v-for="repo in repos" :key="repo.Url" value="repo.Url"
                >{{ repo.Name }}
              </option>
            </select>
          </div>
        </div>
      </div>
    </div>
    <div class="section">
      <!-- <vue-autosuggest
        :suggestions="[
          {
            data: [
              'Frodo',
              'Samwise',
              'Gandalf',
              'Galadriel',
              'Faramir',
              'Éowyn'
            ]
          }
        ]"
        :input-props="{
          class: 'input',
          id: 'autosuggest__input',
          placeholder: 'Do you feel lucky, punk?'
        }"
        @input="onInputChange"
        @selected="selectHandler"
        @click="clickHandler"
      >
        <template slot-scope="{ suggestion }">
          <span class="my-suggestion-item">{{ suggestion.item }}</span>
        </template>
      </vue-autosuggest> -->
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
  mounted: async function() {
    const response = await axios.get(`${process.env.VUE_APP_API_BASE}/repos`);
    this.repos = response.data;
  }
};
</script>

<style></style>
