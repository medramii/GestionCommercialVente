<template>
  <div>
    <h2 class="content-block">Statistiques de vente</h2>
    <div class="content-block">
      <TypeVenteChart />
    </div>
  </div>
</template>

<script>
import TypeVenteChart from "../components/dashboard/ventes-statistics.vue";

export default {
  components: {
    TypeVenteChart
  }
};
</script>