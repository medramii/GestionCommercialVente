<template>
    <div>
        <h6>{{details.key}}</h6>
    </div>
</template>

<script>

export default {
  props: {
    details: {
      type: Object,
      default: ()=>{}
    }
  },
  data() {
    return {
      
    };
  },
  methods: {
  }
};
</script>
