<!-- eslint-disable vue/multi-word-component-names -->
<template>
    <form @submit.prevent="onSendApplication"
          id="myDropdown"
          class="form center">
        <h3 class="form__title">Application form</h3>
        <p v-if="errors.length">
            <b>Please correct the following error(s):</b>
            <ul>
                <li v-for="error in errors">{{ error }}</li>
            </ul>
        </p>
        <div>
            <label class="form__label">Name</label>
            <input v-model="applicationData.name"
                   required
                   class="form__input"
                   type="text"
                   name="name"
                   id="" />
        </div>
        <div>
            <label class="form__label">Phone</label>
            <input v-model="applicationData.phone"
                   required
                   class="form__input"
                   type="tel"
                   name="phone"
                   id="" />
        </div>
        <div>
            <label class="form__label">Email</label>
            <input v-model="applicationData.email"
                   required
                   class="form__input"
                   type="email"
                   name=""
                   id="" />
        </div>
        <button type="submit" class="form__button">Send</button>
    </form>
</template>

<script>
    import axios from 'axios';
    export default {
        data() {
            return {
                applicationData: {
                    errors: [],
                    name: '',
                    phone: '',
                    email: '',
                }
            };
        },
        methods: {
            onSendApplication() {
                return axios.post('api/Applications',
                    {
                        name: this.applicationData.name,
                        email: this.applicationData.email,
                        phoneNumber: this.applicationData.phone,
                    });
            }

            checkForm: function (e) {
                if (this.applicationData.name
                    && this.applicationData.email
                    && this.applicationData.phone) {
                    return true;
                }

                this.errors = [];

                if (!this.applicationData.name) {
                    this.errors.push('Name required.');
                }
                if (!this.this.applicationData.email) {
                    this.errors.push('Email required.');
                }
                if (!this.applicationData.phone) {
                    this.errors.push('Phone required.');
                }

                e.preventDefault();
            }
        },
    };
</script>
