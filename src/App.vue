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
              <option value="0">Static Web Apps</option>
              <option value="1">Azure Functions</option>
            </select>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "App"
};
</script>

<style></style>
