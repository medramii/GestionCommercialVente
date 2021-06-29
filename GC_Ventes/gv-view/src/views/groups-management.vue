<template>
  <div>
    <h2 class="content-block">Gestion des groupes d'utilisateurs</h2>
    <div class="content-block">
        <rights/>
    </div>
  </div>
</template>

<script>
import rights from "../components/rights";

export default {
  components: {
    rights
  }
};
</script>