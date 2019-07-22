import { createReducer, on } from '@ngrx/store';
import { getAllUsers } from './user.actions';

export const initialState = 0;

export const userReducer = createReducer(initialState,
  on(getAllUsers, state => state)
);