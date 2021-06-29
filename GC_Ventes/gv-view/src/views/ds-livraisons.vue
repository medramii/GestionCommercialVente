<template>
  <div>
    <h2 class="content-block">État du bon de livraison</h2>
    <div class="content-block">
      <VenteChart />
    </div>
  </div>
</template>

<script>
import VenteChart from "../components/dashboard/etat-livraison.vue";

export default {
  components: {
    VenteChart
  }
};
</script>